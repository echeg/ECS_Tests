using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System162 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component431> _p1;
EcsPool<Component39> _p2;
EcsPool<Component378> _p3;
EcsPool<Component357> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component39>().Inc<Component378>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component431>();
   _p2 = _world.GetPool<Component39>();
   _p3 = _world.GetPool<Component378>();
   _p4 = _world.GetPool<Component357>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
