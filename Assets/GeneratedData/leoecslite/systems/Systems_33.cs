using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component37> _p1;
EcsPool<Component77> _p2;
EcsPool<Component257> _p3;
EcsPool<Component241> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component37>().Inc<Component77>().Inc<Component257>().Inc<Component241>().End();
   _p1 = _world.GetPool<Component37>();
   _p2 = _world.GetPool<Component77>();
   _p3 = _world.GetPool<Component257>();
   _p4 = _world.GetPool<Component241>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
