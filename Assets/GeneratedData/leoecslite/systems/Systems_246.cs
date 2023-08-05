using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System246 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component150> _p2;
EcsPool<Component315> _p3;
EcsPool<Component175> _p4;
EcsPool<Component164> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component150>().Inc<Component315>().Inc<Component175>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component150>();
   _p3 = _world.GetPool<Component315>();
   _p4 = _world.GetPool<Component175>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component164>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl0.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

}
