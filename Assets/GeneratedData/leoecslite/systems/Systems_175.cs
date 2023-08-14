using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System175 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component119> _p1;
EcsPool<Component409> _p2;
EcsPool<Component161> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component119>().Inc<Component409>().Inc<Component161>().End();
   _p1 = _world.GetPool<Component119>();
   _p2 = _world.GetPool<Component409>();
   _p3 = _world.GetPool<Component161>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
