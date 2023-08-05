using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System240 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component202> _p1;
EcsPool<Component259> _p2;
EcsPool<Component244> _p3;
EcsPool<Component292> _p4;
EcsPool<Component92> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component202>().Inc<Component259>().Inc<Component244>().Inc<Component292>().End();
   _p1 = _world.GetPool<Component202>();
   _p2 = _world.GetPool<Component259>();
   _p3 = _world.GetPool<Component244>();
   _p4 = _world.GetPool<Component292>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component92>();
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
