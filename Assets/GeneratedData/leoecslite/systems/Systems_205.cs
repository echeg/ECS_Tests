using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System205 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component23> _p1;
EcsPool<Component433> _p2;
EcsPool<Component60> _p3;
EcsPool<Component240> _p4;
EcsPool<Component373> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component23>().Inc<Component433>().Inc<Component60>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component23>();
   _p2 = _world.GetPool<Component433>();
   _p3 = _world.GetPool<Component60>();
   _p4 = _world.GetPool<Component240>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component373>();
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
