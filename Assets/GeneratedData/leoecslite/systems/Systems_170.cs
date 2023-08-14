using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System170 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component181> _p1;
EcsPool<Component246> _p2;
EcsPool<Component255> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component181>().Inc<Component246>().Inc<Component255>().End();
   _p1 = _world.GetPool<Component181>();
   _p2 = _world.GetPool<Component246>();
   _p3 = _world.GetPool<Component255>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
