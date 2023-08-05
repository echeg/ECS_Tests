using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System211 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component386> _p1;
EcsPool<Component133> _p2;
EcsPool<Component75> _p3;
EcsPool<Component301> _p4;
EcsPool<Component175> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component386>().Inc<Component133>().Inc<Component75>().Inc<Component301>().End();
   _p1 = _world.GetPool<Component386>();
   _p2 = _world.GetPool<Component133>();
   _p3 = _world.GetPool<Component75>();
   _p4 = _world.GetPool<Component301>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component175>();
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
