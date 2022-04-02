using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component460> _p1;
EcsPool<Component346> _p2;
EcsPool<Component144> _p3;
EcsPool<Component409> _p4;
EcsPool<Component253> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component460>().Inc<Component346>().Inc<Component144>().Inc<Component409>().End();
   _p1 = _world.GetPool<Component460>();
   _p2 = _world.GetPool<Component346>();
   _p3 = _world.GetPool<Component144>();
   _p4 = _world.GetPool<Component409>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component253>();
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
