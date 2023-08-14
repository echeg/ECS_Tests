using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System122 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component436> _p1;
EcsPool<Component313> _p2;
EcsPool<Component495> _p3;
EcsPool<Component142> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component436>().Inc<Component313>().Inc<Component495>().Inc<Component142>().End();
   _p1 = _world.GetPool<Component436>();
   _p2 = _world.GetPool<Component313>();
   _p3 = _world.GetPool<Component495>();
   _p4 = _world.GetPool<Component142>();
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
