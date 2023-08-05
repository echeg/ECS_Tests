using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System235 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component55> _p1;
EcsPool<Component30> _p2;
EcsPool<Component485> _p3;
EcsPool<Component280> _p4;
EcsPool<Component22> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component55>().Inc<Component30>().Inc<Component485>().Inc<Component280>().End();
   _p1 = _world.GetPool<Component55>();
   _p2 = _world.GetPool<Component30>();
   _p3 = _world.GetPool<Component485>();
   _p4 = _world.GetPool<Component280>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component22>();
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
